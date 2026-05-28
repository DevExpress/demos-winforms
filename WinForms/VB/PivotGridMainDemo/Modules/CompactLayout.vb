Imports System
Imports System.Drawing
Imports System.ComponentModel

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class CompactLayout
        Inherits TutorialControl

        Protected Overrides ReadOnly Property HideCustFormWhenSwitchDemo As Boolean
            Get
                Return True
            End Get
        End Property

        Public Sub New()
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

        Protected ReadOnly Property IsCompactLayout As Boolean
            Get
                Return CBool(groupLayout.EditValue)
            End Get
        End Property

        Private Sub CompactLayout_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.BeginUpdate()
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            pivotGridControl1.ValueImages = CategoryImageList
            pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = True
            pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = True
            pivotGridControl1.EndUpdate()
            groupLayout.SelectedIndex = 0
            ChangeCustomizationFormState()
        End Sub

        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso (IsCompactLayout OrElse Equals(e.ValueType, PivotGridValueType.Value)) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        '<groupLayout>
        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.OptionsView.ShowColumnHeaders = Not IsCompactLayout
            pivotGridControl1.OptionsView.ShowRowHeaders = Not IsCompactLayout
            pivotGridControl1.OptionsView.ShowDataHeaders = Not IsCompactLayout
            pivotGridControl1.OptionsView.RowTotalsLocation = If(IsCompactLayout, PivotRowTotalsLocation.Tree, PivotRowTotalsLocation.Far)
            pivotGridControl1.BestFit()
        End Sub

        '</groupLayout>
        Private customizationFormShown As Boolean = False

        Private Sub ChangeCustomizationFormState()
            If customizationFormShown Then
                pivotGridControl1.HideCustomization()
            Else
                pivotGridControl1.ShowCustomization()
            End If
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ChangeCustomizationFormState()
        End Sub

        Private Sub pivotGridControl1_HideCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            simpleButton1.Text = "Show Customization Form"
            customizationFormShown = False
        End Sub

        Private Sub pivotGridControl1_ShowCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
            simpleButton1.Text = "Hide Customization Form"
            customizationFormShown = True
        End Sub
    End Class
End Namespace
