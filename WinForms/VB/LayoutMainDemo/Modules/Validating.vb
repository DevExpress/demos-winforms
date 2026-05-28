Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace DevExpress.XtraLayout.Demos

    ''' <summary>
    ''' Summary description for Employees.
    ''' </summary>
    Public Partial Class Validating
        Inherits DevExpress.XtraLayout.Demos.TutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            layoutControl1.SetDefaultLayout()
            InitData()
        ' TODO: Add any initialization after the InitForm call
        End Sub

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "Validating"
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"Validating"}
            End Get
        End Property

        Protected Overrides Sub OnVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Visible Then
                InitFields()
                ValidateFields()
            End If

            MyBase.OnVisibleChanged(sender, e)
        End Sub

        Private Sub InitData()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("nwind.xml")
            If Not Equals(DBFileName, "") Then dsCategories1.ReadXml(DBFileName, XmlReadMode.InferSchema)
        End Sub

        Private Sub InitFields()
            productNameTextEdit.Text = ""
            unitsInStockSpinEdit.EditValue = -1
            reorderLevelSpinEdit.EditValue = -1
            discountSpinEdit.EditValue = 0.60D
        End Sub

        Private Sub ValidateFields()
            Validate_EmptyStringRule(productNameTextEdit)
            Validate_LessThanMinRule(productsUnitPriceCalcEdit, Decimal.Zero)
            Validate_LessThanMinRule(orderUnitPriceCalcEdit, Decimal.Zero)
            Validate_LessThanMinRule(quantitySpinEdit, Decimal.Zero)
            Validate_LessThanMinRule(unitsInStockSpinEdit, Decimal.Zero)
            Validate_LessThanMinRule(reorderLevelSpinEdit, Decimal.Zero)
            Validate_LessThanMinRule(unitsOnOrderSpinEdit, Decimal.Zero)
            Validate_BetweenMinAndMaxRule(discountSpinEdit, Decimal.Zero, 0.5D)
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutControl1.BeginUpdate()
            unitsOnOrderSpinEdit.Enabled = Not checkEdit1.Checked
            reorderLevelSpinEdit.Enabled = unitsOnOrderSpinEdit.Enabled
            unitsInStockSpinEdit.Enabled = reorderLevelSpinEdit.Enabled
            productsUnitPriceCalcEdit.Enabled = unitsInStockSpinEdit.Enabled
            supplierLookUpEdit.Enabled = productsUnitPriceCalcEdit.Enabled
            quantityPerUnitTextEdit.Enabled = supplierLookUpEdit.Enabled
            productNameTextEdit.Enabled = quantityPerUnitTextEdit.Enabled
            layoutControl1.EndUpdate()
        End Sub

        Private Sub Detail_Validated(ByVal sender As Object, ByVal e As EventArgs)
            CType(BindingContext(dataNavigator3.DataSource, dataNavigator3.DataMember), CurrencyManager).EndCurrentEdit()
        End Sub

        '<productNameTextEdit>
        Private Sub productNameTextEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Validate_EmptyStringRule(TryCast(sender, BaseEdit))
        End Sub

        '</productNameTextEdit>
        Private Sub unitPriceCalcEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Validate_LessThanMinRule(TryCast(sender, BaseEdit), Decimal.Zero)
        End Sub

        '<unitsInStockSpinEdit>
        Private Sub unitsInStockSpinEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Validate_LessThanMinRule(TryCast(sender, BaseEdit), Decimal.Zero)
        End Sub

        '</unitsInStockSpinEdit>
        '<discountSpinEdit>
        Private Sub discountSpinEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Validate_BetweenMinAndMaxRule(TryCast(sender, BaseEdit), Decimal.Zero, 0.50D)
        End Sub

        '</discountSpinEdit>
        Private Sub dataNavigator3_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            ValidateFields()
        End Sub

        Private Sub dataNavigator2_ButtonClick_1(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs)
            e.Handled = dxErrorProvider1.HasErrors
        End Sub

        '<productNameTextEdit>
        Private Sub Validate_EmptyStringRule(ByVal control As BaseEdit)
            If Equals(control.Text, Nothing) OrElse control.Text.Trim().Length = 0 Then
                dxErrorProvider1.SetError(control, "This field can't be empty", ErrorType.Critical)
            Else
                dxErrorProvider1.SetError(control, "")
            End If
        End Sub

        '</productNameTextEdit>
        '<unitsInStockSpinEdit>
        Private Sub Validate_LessThanMinRule(ByVal control As BaseEdit, ByVal min As Decimal)
            If Not(TypeOf control.EditValue Is Decimal) Then Return
            If CDec(control.EditValue) < min Then
                dxErrorProvider1.SetError(control, "Please enter a greater value than " & min.ToString(), ErrorType.Warning)
            Else
                dxErrorProvider1.SetError(control, "")
            End If
        End Sub

        '</unitsInStockSpinEdit>
        '<discountSpinEdit>
        Private Sub Validate_BetweenMinAndMaxRule(ByVal control As BaseEdit, ByVal min As Decimal, ByVal max As Decimal)
            If Not(TypeOf control.EditValue Is Decimal) Then Return
            Dim val As Decimal = CDec(control.EditValue)
            If val < min Then
                dxErrorProvider1.SetError(control, "Please enter a greater value than " & (min * 100).ToString(), ErrorType.Warning)
            ElseIf val > max Then
                dxErrorProvider1.SetError(control, "Please enter a value less than " & (max * 100).ToString(), ErrorType.Information)
            Else
                dxErrorProvider1.SetError(control, "")
            End If
        End Sub

        '</discountSpinEdit>
        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
