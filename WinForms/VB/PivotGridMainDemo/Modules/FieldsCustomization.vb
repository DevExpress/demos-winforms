Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPivotGrid.Customization

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class FieldsCustomization
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

        Private showCustomization As Boolean = False

        Private Sub FieldsCustomization_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            InitComboBoxes()
            pivotGridControl1.ValueImages = CategoryImageList
            pivotGridControl1.HeaderImages = HeadersImageList
            fieldSalesPerson.ImageIndex = 0
            fieldOrderID.ImageIndex = 1
        End Sub

        Private Sub InitComboBoxes()
            icbCustomizationStyle.Properties.Items.Add("Excel", CustomizationFormStyle.Excel2007, -1)
            icbCustomizationStyle.Properties.Items.Add("Simple", CustomizationFormStyle.Simple, -1)
            icbCustomizationStyle.EditValue = pivotGridControl1.OptionsCustomization.CustomizationFormStyle
        End Sub

        Protected Overrides Sub OnLayoutCalculated()
            MyBase.OnLayoutCalculated()
            pivotGridControl1.FieldsCustomization(pivotGridControl1.PointToScreen(New Point(Width - 300, layoutControlGroup2.Height + 30)))
            pivotGridControl1.CustomizationForm.TopMost = True
        End Sub

        Private Sub InitCustomization(ByVal show As Boolean)
            showCustomization = show
            sbCustomizationForm.Text = If(showCustomization, "Hide Customization Form", "Show Customization Form")
        End Sub

        Private Sub ReShowCustomizationForm()
            If showCustomization Then
                pivotGridControl1.DestroyCustomization()
                Dim showPoint As Point = pivotGridControl1.CustomizationFormBounds.Location
                pivotGridControl1.FieldsCustomization(showPoint)
            End If
        End Sub

        Private Sub pivotGridControl1_ShowCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            InitCustomization(True)
        End Sub

        Private Sub pivotGridControl1_HideCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            InitCustomization(False)
        End Sub

        '<sbCustomizationForm>
        Private Sub sbCustomizationForm_Click(ByVal sender As Object, ByVal e As EventArgs)
            If showCustomization Then
                pivotGridControl1.DestroyCustomization()
            Else
                pivotGridControl1.FieldsCustomization()
            End If
        End Sub

        '</sbCustomizationForm>
        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        '<icbCustomizationStyle>
        Private Sub icbCustomizationStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim style As CustomizationFormStyle = CType(icbCustomizationStyle.EditValue, CustomizationFormStyle)
            pivotGridControl1.OptionsCustomization.CustomizationFormStyle = style
            Dim checkBoxesVisibility As XtraLayout.Utils.LayoutVisibility = If(style = CustomizationFormStyle.Excel2007, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
            lciAllowFilter.Visibility = checkBoxesVisibility
            lciAllowSort.Visibility = checkBoxesVisibility
            ReShowCustomizationForm()
        End Sub

        '</icbCustomizationStyle>
        '<ceSearchBox>
        Private Sub OnSearchBoxVisibilityChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.OptionsCustomization.CustomizationFormSearchBoxVisible = ceSearchBox.Checked
            ReShowCustomizationForm()
        End Sub

        '</ceSearchBox>
        '<ceAllowFilter>
        Private Sub ceAllowFilter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = ceAllowFilter.Checked
        End Sub

        '</ceAllowFilter>
        '<ceAllowSort>
        Private Sub ceAllowSort_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = ceAllowSort.Checked
        End Sub
    '</ceAllowSort>
    End Class
End Namespace
