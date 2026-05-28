Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class RunTimeChangeSummaryType
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            UpdateDataFields()
            UpdateHintLabelVisibility()
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

        Private Sub UpdateHintLabelVisibility()
            layoutControlItem3.Visibility = If(checkEdit2.Checked, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
        End Sub

        '<checkEdit1>
        '<checkEdit2>
        Private Sub checkEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateDataFields()
            UpdateHintLabelVisibility()
        End Sub

        Private Sub UpdateDataFields()
            pivotGridControl1.BeginUpdate()
            Dim fields As PivotGridFieldCollection = pivotGridControl1.Fields
            Dim dataFields As List(Of PivotGridField) = pivotGridControl1.GetFieldsByArea(PivotArea.DataArea)
            For Each field In dataFields
                fields.Remove(field)
            Next

            If checkEdit1.Checked Then
                Dim summaryTypes As PivotSummaryType() = New PivotSummaryType() {PivotSummaryType.Sum, PivotSummaryType.Average, PivotSummaryType.Count, PivotSummaryType.Max}
                For Each summaryType In summaryTypes
                    fields.Add(CreateDataField(CType(summaryType, PivotSummaryType)))
                Next

                pivotGridControl1.Fields("ProductName").Width = 350
            Else
                Dim dataField As PivotGridField = CreateDataField(PivotSummaryType.Sum)
                fields.Add(dataField)
                dataField.Appearance.Header.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
                dataField.Appearance.Header.Options.UseBackColor = True
                pivotGridControl1.Fields("ProductName").Width = 200
            End If

            pivotGridControl1.EndUpdate()
        End Sub

        Private Function CreateDataField(ByVal summaryType As PivotSummaryType) As PivotGridField
            Dim field As PivotGridField = New PivotGridField()
            field.Options.ShowSummaryTypeName = True
            field.Options.AllowRunTimeSummaryChange = checkEdit2.Checked
            field.DataBinding = New ExpressionDataBinding("[Discount]*[Extended Price]")
            field.Area = PivotArea.DataArea
            field.Caption = "Discount"
            field.SummaryType = summaryType
            field.CellFormat.FormatType = FormatType.Numeric
            field.CellFormat.FormatString = "c2"
            Return field
        End Function
    '</checkEdit2>
    '</checkEdit1>        
    End Class
End Namespace
